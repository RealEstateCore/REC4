[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Differential_Setpoint](Differential_Setpoint.md) > [Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Setpoint](#)
# Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Setpoint

**Display name:** Medium Temperature Hot Water Differential Pressure Load Shed Set<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Medium_Temperature_Hot_Water_Differential_Pressure_Load_Shed_Setpoint;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
