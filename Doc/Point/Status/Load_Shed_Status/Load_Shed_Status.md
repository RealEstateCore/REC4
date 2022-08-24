[Point](../../Point.md) > [Status](../Status.md) > [Load_Shed_Status](.)
# Load_Shed_Status

**Display name:** Load Shed Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Load_Shed_Status;1

---


## Child interfaces
* [Differential_Pressure_Load_Shed_Status](../Pressure_Status/Differential_Pressure_Load_Shed_Status/Differential_Pressure_Load_Shed_Status.md)
* [Entering_Hot_Water_Temperature_Load_Shed_Status](Entering_Hot_Water_Temperature_Load_Shed_Status/Entering_Hot_Water_Temperature_Load_Shed_Status.md)
* [Leaving_Hot_Water_Temperature_Load_Shed_Status](Leaving_Hot_Water_Temperature_Load_Shed_Status/Leaving_Hot_Water_Temperature_Load_Shed_Status.md)

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
