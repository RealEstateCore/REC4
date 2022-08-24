[Point](../../Point.md) > [Status](../Status.md) > [Mode_Status](.)
# Mode_Status

**Display name:** Mode Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Mode_Status;1

---


## Child interfaces
* [Speed_Mode_Status](../Speed_Status/Speed_Mode_Status.md)
* [Zone_Air_Conditioning_Mode_Status](Zone_Air_Conditioning_Mode_Status.md)
* [Cooling_Mode_Status](Cooling_Mode_Status/Cooling_Mode_Status.md)
* [Heating_Mode_Status](Heating_Mode_Status/Heating_Mode_Status.md)
* [Occupied_Mode_Status](Occupied_Mode_Status/Occupied_Mode_Status.md)
* [Operating_Mode_Status](Operating_Mode_Status/Operating_Mode_Status.md)
* [Unoccupied_Mode_Status](Unoccupied_Mode_Status/Unoccupied_Mode_Status.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
