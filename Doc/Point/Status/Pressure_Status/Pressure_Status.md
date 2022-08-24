[Point](../../Point.md) > [Status](../Status.md) > [Pressure_Status](#)
# Pressure_Status

**Display name:** Pressure Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pressure_Status;1

---


## Child interfaces
* [Discharge_Air_Duct_Pressure_Status](Discharge_Air_Duct_Pressure_Status.md)
* [Supply_Air_Duct_Pressure_Status](Supply_Air_Duct_Pressure_Status.md)
* [Differential_Pressure_Load_Shed_Status](Differential_Pressure_Load_Shed_Status/Differential_Pressure_Load_Shed_Status.md)

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
