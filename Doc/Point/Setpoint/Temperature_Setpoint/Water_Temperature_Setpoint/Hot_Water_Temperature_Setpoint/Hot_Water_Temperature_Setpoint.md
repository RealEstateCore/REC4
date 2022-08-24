[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../Water_Temperature_Setpoint.md) > [Hot_Water_Temperature_Setpoint](#)
# Hot_Water_Temperature_Setpoint

**Display name:** Hot Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Hot_Water_Temperature_Setpoint;1

---


## Child interfaces
* [Entering_Hot_Water_Temperature_Setpoint](Entering_Hot_Water_Temperature_Setpoint.md)
* [Leaving_Hot_Water_Temperature_Setpoint](../Leaving_Water_Temperature_Setpoint/Leaving_Hot_Water_Temperature_Setpoint.md)
* [Domestic_Hot_Water_Temperature_Setpoint](Domestic_Hot_Water_Temperature_Setpoint/Domestic_Hot_Water_Temperature_Setpoint.md)

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
